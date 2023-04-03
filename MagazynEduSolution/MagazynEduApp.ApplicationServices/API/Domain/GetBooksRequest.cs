using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MagazynEduApp.ApplicationServices.API.Domain
{
    public class GetBooksRequest : IRequest<GetBooksResponse>
    {
    }
}
