﻿namespace CarRentalSystem.Infrastructure.Persistence.Repositories
{
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Contracts;
    using Domain.Common;

    internal class DataRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IAggregateRoot
    {
        protected CarRentalDbContext db;
        public DataRepository(CarRentalDbContext db) => this.db = db;


        public IQueryable<TEntity> All() => this.db.Set<TEntity>();

        public async Task<int> SaveChanges(CancellationToken cancellationToken = default) => await this.db.SaveChangesAsync(cancellationToken);
    }
}
