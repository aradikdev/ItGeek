using ItGeek.BLL;
using Microsoft.AspNetCore.Mvc;

namespace ItGeek.Web.Components;

public class LastsViewComponent : ViewComponent
{
    private readonly UnitOfWork _uow;

    public LastsViewComponent(UnitOfWork uow)
    {
        _uow = uow;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
        var qwe = await _uow.PostRepository.GetLastAsync(6);
        return View(qwe);
    }
}
