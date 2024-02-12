using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NSPS.Domain.Entities;
using NSPS.Domain.ValueObjects;

namespace NSPS.Infra.Configurations;

internal class VBProductConfig : IEntityTypeConfiguration<VBProduct>
{
    public void Configure(EntityTypeBuilder<VBProduct> builder)
    {
        builder.HasKey(vbp => vbp.Code);

        //maping
        builder.Property(product => product.Code).HasConversion(
            codeOut => codeOut.ProdCode,
            codein => ProductCode.Create(codein));

        builder.Property(product => product.Name).HasConversion(
            nameOut => nameOut.ProdName,
            namein => ProductName.Create(namein));

        builder.Property(product => product.Description).HasConversion(
                    DescriOut => DescriOut.ProdDescription,
                    Descriin => ProductDescription.Create(Descriin));

        builder.Property(product => product.Cost).HasConversion(
                    codeOut => codeOut.ProdCost,
                    codein => ProductCost.Create(codein));

    }
}
