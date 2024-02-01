using MediatR;
using NSPS.Domain.ValueObjects;

namespace NSPS.Application.ProductActions;

public sealed record CreateProductCommand  (string pName,
                                            double pCode,
                                            double pCost,
                                            string pDescription) : IRequest
{   }
