
using FitFusion.Entity.NewEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.DAL.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(x => x.Mail).IsRequired();
        builder.Property(x=> x.Password).IsRequired();
        builder.Property(x=> x.FirstName).IsRequired();
        builder.Property(x=> x.LastName).IsRequired();

        builder.Property(x => x.CreateDate).IsRequired();
        builder.Property(x => x.UpdateDate).IsRequired(false);
        builder.Property(x => x.DeleteDate).IsRequired(false);
        builder.Property(x => x.Statu).IsRequired();
        builder.HasOne(x => x.UserDetail).WithOne(x => x.User).HasForeignKey<UserDetail>(x=> x.UserId);
        builder.HasData(
            
            new User { FirstName = "admin", LastName = "admin", Mail = "admin", Password = " " ,IsAdmin=true }
            );
    }
}
