using GraphQL.Models;
using GraphQL.Repositories;

namespace GraphQL
{
    public class Mutation
    {
        private readonly IRepository _repository;

        public Mutation(IRepository repository)
        {
            _repository = repository;
        }
    }
}
