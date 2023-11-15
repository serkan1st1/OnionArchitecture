using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Orders.Commands.CreateOrderCommand
{
    public sealed record CreateOrderCommandResponse(
        string Message="Siparişiniz başarıyla oluşturuldu.");
   
}
