using Library.Configurations.CacheService;
using Library.Models.Branch;
using Library.Models.NameAndIdDTO;
using Library.Repositories;
using Library.UnitsOfWork.BranchUoW;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchUnitOfWork _branchUnitOfWork;
        private readonly ICacheService _cacheService;

        public BranchController(IBranchUnitOfWork branchUnitOfWork, ICacheService cacheService)
        {
            _branchUnitOfWork = branchUnitOfWork;
            _cacheService = cacheService;
        }

        // GET: api/<BranchController>
        [HttpGet]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<ActionResult<IEnumerable<Branch>>> GetAllBranches()
        {
            //checking cache
            var branchCache = _cacheService.GetData<IEnumerable<Branch>>("Branches");

            if (!branchCache.IsNullOrEmpty())
                return Ok(branchCache);

            var branches = await _branchUnitOfWork.GetAllBranches();

            if (branches.IsNullOrEmpty())
                return NotFound("No Branches Found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData<IEnumerable<Branch>>("Branches", branches , cacheExpiry);

            return Ok(branches);
        }

        // GET: api/<EmployeeController>/Branches_Ids
        [HttpGet("Branches_Ids")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<int>>> GetAllManagerIds()
        {
            //checking cache
            var branchCache = _cacheService.GetData<IEnumerable<int>>("BranchIds");

            if (!branchCache.IsNullOrEmpty())
                return Ok(branchCache);

            var ids = await _branchUnitOfWork.GetAllBranchesIds();

            if (ids.IsNullOrEmpty())
                return NotFound("No branch Ids Found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData<IEnumerable<int>>("BranchIds", ids, cacheExpiry);

            return Ok(ids);
        }

        // GET: api/<EmployeeController>/Branch_Names
        [HttpGet("Branch_Names")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<string>>> GetAllBranchNames()
        {
            //checking cache
            var branchCache = _cacheService.GetData<IEnumerable<string>>("BranchNames");

            if (!branchCache.IsNullOrEmpty())
                return Ok(branchCache);

            var names = await _branchUnitOfWork.GetAllBranchNames();

            if (names.IsNullOrEmpty())
                return NotFound("No branch Names Found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData<IEnumerable<string>>("BranchNames", names, cacheExpiry);

            return Ok(names);
        }

        // GET api/<BranchController>/5
        [HttpGet("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<ActionResult<Branch>> GetBranchById(int id)
        {
            //checking cache
            var branchCache = _cacheService.GetData<Branch>($"branch{id}");

            if (branchCache != null)
                return Ok(branchCache);

            var branch = await _branchUnitOfWork.GetBranchByID(id);

            if (branch == null)
                return NotFound("Invalid Id");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(5);
            _cacheService.SetData($"branch{id}", branch, cacheExpiry);

            return Ok(branch);
        }

        // GET api/<BranchController>
        [HttpGet("Locations")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<BranchLocationDTO>?>> GetBranchLocations()
        {
            //checking cache
            var branchCache = _cacheService.GetData<IEnumerable<BranchLocationDTO>>($"branchLocation");

            if (branchCache != null)
                return Ok(branchCache);

            var branchLocations = await _branchUnitOfWork.GetBranchLocation();

            if (branchLocations.IsNullOrEmpty())
                return NotFound($"branch Locations not found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(2);
            _cacheService.SetData($"branchLocation", branchLocations, cacheExpiry);

            return Ok(branchLocations);
        }

        // GET api/<BranchController>/Ids_And_Names
        [HttpGet("Ids_And_Names")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<Name_Id_DTO>>> GetBranchIdsAndNames()
        {
            //checking cache
            var branchCache = _cacheService.GetData<IEnumerable<Name_Id_DTO>>("branchNamesAndIds");

            if (branchCache != null)
                return Ok(branchCache);

            var namesAndIds = await _branchUnitOfWork.GetBranchIdsAndNames();

            if (namesAndIds == null)
                return NotFound($"branches are not found");

            //adding cache
            var cacheExpiry = DateTimeOffset.Now.AddMinutes(2);
            _cacheService.SetData("branchNamesAndIds", namesAndIds, cacheExpiry);

            return Ok(namesAndIds);
        }

        // POST api/<BranchController>
        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<IActionResult> InsertBranch(Branch branch)
        {

            int affected_rows = await _branchUnitOfWork.InsertBranch(branch);

            if (affected_rows > 0)
            {

                //removing invalid cache
                _cacheService.RemoveData("Branches");
                _cacheService.RemoveData("BranchIds");
                _cacheService.RemoveData("BranchNames");
                _cacheService.RemoveData("branchNamesAndIds");
                return Ok("Branch Added Successfully");
            }
            else if (affected_rows == -1)
            {
                return BadRequest("something went wrong, please check your info and try again");
            }
            else
                throw new Exception("Insertion failed, Try agian");
        }

        // PUT api/<BranchController>/5
        [HttpPut("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<IActionResult> UpdateBranchManager(int id, BranchUpdateDTO dto)
        {
            var affected_rows = await _branchUnitOfWork.UpdateBranchManagerById(id, dto);

            if (affected_rows > 0)
            {
                //Removing invalid cache
                _cacheService.RemoveData("Branches");
                _cacheService.RemoveData("BranchIds");
                _cacheService.RemoveData("BranchNames");
                _cacheService.RemoveData("branchNamesAndIds");
                _cacheService.RemoveData($"branch{id}");

                return Ok("Branch updated successfully");
            }
            else if (affected_rows == -1)
            {
                return BadRequest("something went wrong, please check your info and try again");
            }
            return NotFound("Branch Not Found! Check id and try again");
        }

        // DELETE api/<BranchController>/5
        [HttpDelete("{id}")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "manager")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            int affected_rows = await _branchUnitOfWork.DeleteBranchById(id);

            if (affected_rows > 0)
            {
                //removing invalid cache
                _cacheService.RemoveData($"branch{id}");
                _cacheService.RemoveData("BranchIds");
                _cacheService.RemoveData("BranchNames");
                _cacheService.RemoveData("branchNamesAndIds");
                _cacheService.RemoveData("Branches");

                return Ok("Branch Deleted Successfully");
            }
            return NotFound("Branch with id = " + id + " does not exists");
        }
    }
}
