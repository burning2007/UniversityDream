using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GF.Domain.Context;
using GF.Infrastructure.Data.Seedwork;
using System.Linq.Expressions;
using System.Data.Objects;

namespace GF.Infrastructure.Data.Context
{
    public class ScorePublishRepository : Repository<ScorePublish>, IScorePublishRepository
    {
        private ApplicationContext appContext;
        public ScorePublishRepository()
            : base()
        {
            context = new ApplicationContext();
            appContext = (ApplicationContext)context;
        }

        public override void Add(ScorePublish scorePublish)
        {
            if (scorePublish == null)
                throw new ArgumentNullException("scorePublish");

            appContext.AddToScorePublishes(scorePublish);
        }

        public override IList<ScorePublish> GetFiltered(Expression<Func<ScorePublish, bool>> filter)
        {
            return appContext.ScorePublishes.Where(filter).ToList<ScorePublish>();
        }

        public ScorePublish GetByProvince(Guid provinceId)
        {
            return appContext.GetScorePublishByProvinceId(provinceId).SingleOrDefault<ScorePublish>();
        }

        public override void TrackEntity(ScorePublish scorePublish)
        {
            if (scorePublish == null)
                throw new ArgumentNullException("scorePublish");

            context.AttachTo("ScorePublishs", scorePublish);
            context.ObjectStateManager.ChangeObjectState(scorePublish, System.Data.EntityState.Unchanged);
        }

        public override void Merge(ScorePublish scorePublish)
        {
            if (scorePublish == null)
                throw new ArgumentNullException("scorePublish");

            context.ApplyCurrentValues<ScorePublish>("ScorePublishs", scorePublish);
        }

        public override void Modify(ScorePublish scorePublish)
        {
            if (scorePublish != (ScorePublish)null)
            {
                appContext.AttachTo("ScorePublishs", scorePublish);
                appContext.ObjectStateManager.ChangeObjectState(scorePublish, System.Data.EntityState.Modified);
            }
        }

        public override void Refresh(object scorePublish, RefreshMode refreshMode = RefreshMode.StoreWins)
        {
            appContext.Refresh(refreshMode, scorePublish);
        }

        public override void Remove(ScorePublish scorePublish)
        {
            if (scorePublish == null)
                throw new ArgumentNullException("scorePublish");

            appContext.DeleteObject(scorePublish);
        }



    }
}
