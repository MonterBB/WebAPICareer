
using Microsoft.EntityFrameworkCore;

namespace WebAPI
{
    public class KnowledgeRepo
    {
        private readonly ItsmWorkContext _dbContext;

        public KnowledgeRepo(ItsmWorkContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Guid CreateKnowledgeBase(KnowledgeBase knowledgeBase)
        {
            _dbContext.Add(knowledgeBase);
            _dbContext.SaveChanges();

            return knowledgeBase.Id;
        }

        public KnowledgeBase GetById(Guid id)
        {
            return _dbContext.KnowledgeBases
                .Where(knowledgeBase => knowledgeBase.Id == id)
                .FirstOrDefault();
        }

        public bool UpdateNameById(Guid id, string newName)
        {
            var result = false;

            var knowledgeBase = GetById(id);

            if (knowledgeBase == null)
            {
                return result;
            }

            knowledgeBase.Name = newName;

            _dbContext.Entry(knowledgeBase).State = EntityState.Modified;
            var count = _dbContext.SaveChanges();

            if (count > 0)
            {
                result = true;
            }

            return result;
        }

        public bool DeleteById(Guid id)
        {
            var result = false;

            var knowledgeBase = GetById(id);

            if (knowledgeBase == null)
            {
                return result;
            }

            _dbContext.Remove(knowledgeBase);
            var count = _dbContext.SaveChanges();

            if (count > 0)
            {
                result = true;
            }

            return result;
        }
    }
}
