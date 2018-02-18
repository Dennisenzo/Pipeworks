using Microsoft.AspNetCore.Mvc;

namespace Denga.Pipeworks.HttpCommunication
{
    [Route("api/[controller]")]
    public class ManagementController:Controller
    {
        private readonly DataContext db;

        public ManagementController(DataContext db) => this.db = db;

        //[HttpGet]
        //public IEnumerable<OcmActionModel> Get()
        //{
        //    var actions = db.Actions
        //        .Include(a => a.CreatedBy)
        //        .Include(a => a.ExecutedBy)
        //        .Include(a => a.Customer)
        //        .Include(a => a.Vehicle)
        //        .Include(a => a.Driver)
        //        .Include(a => a.Status)
        //        .Include(a => a.Type)
        //        .ToList();

        //    return actions.Select(OcmActionModel.FromDomain);
        //}

        //[Route("{id:int}")]
        //[HttpGet]
        //public OcmActionModel Get(int id)
        //{
        //    var action = db.Actions
        //        .Include(a => a.CreatedBy)
        //        .Include(a => a.ExecutedBy)
        //        .Include(a => a.Customer)
        //        .Include(a => a.Vehicle)
        //        .Include(a => a.Driver)
        //        .Include(a => a.Status)
        //        .Include(a => a.Type)
        //        .SingleOrDefault(a => a.Id == id);

        //    return OcmActionModel.FromDomain(action);
        //}

    }
}
