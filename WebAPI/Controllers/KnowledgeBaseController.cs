using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KnowledgeBaseController : ControllerBase
    {
        KnowledgeRepo _knowledgeRepo;

        public KnowledgeBaseController(KnowledgeRepo knowledgeRepo)
        {
            _knowledgeRepo = knowledgeRepo;
        }

        [HttpGet(Name = "GetKnowledgeBase")]
        public KnowledgeBase GetKnowledgeBaseById(Guid id)
        {
            var testHeader = HttpContext?.Request?.Headers["Test"];
            
            Validator.GuidValidator(id);

            return _knowledgeRepo.GetById(id);
        }

        [HttpPost(Name = "AddKnowledgeBase")]
        public Guid AddKnowledgeBase(KnowledgeBase knowledgeBase)
        {
            Validator.ObjectValidator(knowledgeBase);

            return _knowledgeRepo.CreateKnowledgeBase(knowledgeBase);
        }

        [HttpPut(Name = "UpdateKnowledgeBase")]
        public bool UpdateKnowledgeBase(KnowledgeBase knowledgeBase)
        {
            Validator.ObjectValidator(knowledgeBase);

            return _knowledgeRepo.Update(knowledgeBase);
        }

        [HttpDelete(Name = "DeleteKnowledgeBase")]
        public bool DeleteKnowledgeBase(Guid id)
        {
            Validator.GuidValidator(id);

            return _knowledgeRepo.DeleteById(id);
        }
    }
}
