
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

        public virtual Guid CreateKnowledgeBase(KnowledgeBase knowledgeBase)
        {
            _dbContext.Add(knowledgeBase);
            _dbContext.SaveChanges();

            return knowledgeBase.Id;
        }

        public virtual KnowledgeBase GetById(Guid id)
        {
            return _dbContext.KnowledgeBases
                .Where(knowledgeBase => knowledgeBase.Id == id)
                .FirstOrDefault();
        }

        public virtual bool Update(KnowledgeBase knowledgeBase)
        {
            var result = false;

            if (knowledgeBase == null)
            {
                return result;
            }

            _dbContext.Entry(knowledgeBase).State = EntityState.Modified;
            var count = _dbContext.SaveChanges();

            if (count > 0)
            {
                result = true;
            }

            return result;
        }

        public virtual bool DeleteById(Guid id)
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
