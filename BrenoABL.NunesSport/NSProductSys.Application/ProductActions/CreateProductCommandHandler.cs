using MediatR;
using NSPS.Domain.ValueObjects;

namespace NSPS.Application.ProductActions;

internal sealed class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
{
    //public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    //{
    //    var prodName        = ProductName.Creater(request.pName);
    //    var prodCode        = ProductCode.Create(request.pCode);
    //    var prodCost        = ProductCost.Create(request.pCost);
    //    var prodDescription = ProductDescription.Create(request.pDescription);
    //
    //
    //}
    public Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
