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
        public Guid AddKnowledgeBase()
        {
            var content = HttpContext.Request.ReadFromJsonAsync<KnowledgeBase>();
            var knowledgeBase = content.Result;

            Validator.ObjectValidator(knowledgeBase);

            return _knowledgeRepo.CreateKnowledgeBase(knowledgeBase);
        }

        [HttpPut(Name = "UpdateKnowledgeBase")]
        public string UpdateKnowledgeBase(Guid id)
        {
            Validator.GuidValidator(id);

            var content = HttpContext.Request.ReadFromJsonAsync<KnowledgeBase>();
            var knowledgeBaseName = content.Result.Name;

            Validator.StringValidator(knowledgeBaseName);

            var result = _knowledgeRepo.UpdateNameById(id, knowledgeBaseName);

            if (!result)
            {
                return "Название статьи не изменено.";
            }

            return $"Новое название статьи {knowledgeBaseName}";
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
