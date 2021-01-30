using Data;
using Models.GunModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GunsService
    {
        public bool CreateGuns(GunCreate gunsToCreate)
        {
            var entity =
                new Guns()
                {
                    Title = gunsToCreate.Title,
                    Lazers = gunsToCreate.Lazers,

                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Guns.Add(entity);
                return ctx.SaveChanges() == 1;
            }


        }
        public IEnumerable<GunListltem> GetGuns()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Guns
                        .Select(
                            e =>
                                new GunListltem
                                {
                                    GunsId = e.GunsId,
                                    Title = e.Title,


                                }
                        );

                return query.ToArray();
            }
        }
        public GunDetail GetGunsById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Guns
                        .Single(e => e.GunsId == id);
                return
                    new GunDetail
                    {
                        GunsId = entity.GunsId,
                        Title = entity.Title,
                        Gun = entity.Gun,
                        Lazers = entity.Lazers,
                        Grips = entity.Grips,
                        Mag = entity.Mag,
                        Muzzle = entity.Muzzle,
                        Sights = entity.Sights,


                    };
            }



        }
        public bool UpdateGuns(GunEdit gunToBeUpdated)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Guns
                        .Single(e => e.GunsId == gunToBeUpdated.GunsId);

                entity.Title = gunToBeUpdated.Title;
                entity.Gun = gunToBeUpdated.Gun;
                entity.Lazers = gunToBeUpdated.Lazers;
                entity.Sights = gunToBeUpdated.Sights;
                entity.Grips = gunToBeUpdated.Grips;
                entity.Mag = gunToBeUpdated.Mag;
                entity.Muzzle = gunToBeUpdated.Muzzle;
               

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
