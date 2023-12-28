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
        public KnowledgeBase GetKnowledgeBaseByName(Guid id)
        {
            var testHeader = HttpContext.Request.Headers["Test"];
            
            Validator.GuidValidator(id);

            return _knowledgeRepo.GetById(id);
        }

        [HttpPost(Name = "AddKnowledgeBase")]
        public Guid AddKnowledgeBase(string name)
        {
            Validator.StringValidator(name);

            var knowledgeBase = new KnowledgeBase();
            knowledgeBase.Name = name;

            return _knowledgeRepo.CreateKnowledgeBase(knowledgeBase);
        }

        [HttpPut(Name = "UpdateKnowledgeBase")]
        public string UpdateKnowledgeBase(Guid id, string newName)
        {
            Validator.GuidValidator(id);
            Validator.StringValidator(newName);

            var result = _knowledgeRepo.UpdateNameById(id, newName);

            if (!result)
            {
                return "Название статьи не изменено.";
            }

            return $"Новое название статьи {newName}";
        }

        [HttpDelete(Name = "DeleteKnowledgeBase")]
        public string DeleteKnowledgeBase(Guid id)
        {
            Validator.GuidValidator(id);

            var result = _knowledgeRepo.DeleteById(id);

            if (!result)
            {
                return "Запись не удалена.";
            }

            return $"Запись успешно удалена";
        }
    }
}
