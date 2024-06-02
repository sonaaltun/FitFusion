
using FitFusion.Entity.NewEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.DAL.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(x=>x.CategoryName).IsRequired();
        builder.Property(x=> x.Description).IsRequired();
        builder.Property(x => x.CreateDate).IsRequired();
        builder.Property(x => x.UpdateDate).IsRequired(false);
        builder.Property(x => x.DeleteDate).IsRequired(false);
        builder.Property(x => x.Statu).IsRequired();
        builder.HasData(
            new Category { CategoryName = "Çorbalar", Description = "Çorbalar, sağlıklı bir diyetin önemli bir parçasıdır. Sebzelerden yapılan çorbalar düşük kalorili, yüksek lifli ve besleyicidir. Ayrıca sindirimi kolaydır ve tokluk hissini artırabilir." },
            new Category { CategoryName = "Salatalar", Description = "Salatalar, sağlıklı bir diyetin vazgeçilmez bir parçasıdır. Bol miktarda çeşitli sebzelerle hazırlanabilirler. Renkli sebzelerle yapılan salatalar, vitamin ve mineral bakımından zengindir ve düşük kalorilidir." },
            new Category { CategoryName = "Protein Kaynakları", Description = "Protein kaynakları, kas gelişimi ve tamirinde önemli bir rol oynar. Tavuk, balık, hindi, yumurta, tofu, baklagiller gibi çeşitli protein kaynakları tercih edilebilir. Dengeli bir diyet için protein alımı önemlidir." },
            new Category { CategoryName = "Tam Tahıllar", Description = "Tam tahıllar, lif, vitamin ve mineral bakımından zengin ve sindirimi yavaşlatır. Buğday, arpa, çavdar, yulaf gibi tam tahıllar, kan şekerini dengeler ve uzun süre tokluk sağlar." },
            new Category { CategoryName = "Sebzeler", Description = "Sebzeler, düşük kalorili, lif bakımından zengin ve vitamin ile mineral deposudur. Renkli sebzeler, antioksidanlar açısından zengin olup bağışıklık sistemini güçlendirir. Her öğünde çeşitli sebzeler tüketmek önemlidir." },
            new Category { CategoryName = "Meyveler", Description = "Meyveler, doğal şeker ve lif kaynağıdır. Renkli meyveler, antioksidanlar içerir ve sindirimi kolaydır. Taze veya dondurulmuş meyveler, sağlıklı bir atıştırmalık veya tatlı alternatifi olarak tercih edilebilir." },
            new Category { CategoryName = "Atıştırmalıklar", Description = "Sağlıklı atıştırmalıklar, açlık hissini bastırırken besin değerini artırır. Fındık, yoğurt, tam tahıllı krakerler, meyve dilimleri gibi besleyici atıştırmalıklar tercih edilmelidir." }
            ) ;
    }
}
