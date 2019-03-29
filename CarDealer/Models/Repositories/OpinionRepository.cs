namespace CarDealer.Models.Repositories
{
    public class OpinionRepository : IOpinionRepository
    {
        private readonly AppDBContext appDBContext;

        public OpinionRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public void AddOpinion(Opinion opinion)
        {
            appDBContext.Opinions.Add(opinion);
            appDBContext.SaveChanges();
        }
    }
}
