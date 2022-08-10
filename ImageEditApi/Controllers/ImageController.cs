using ImageEditApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImageEditApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        [HttpPost]
        public EditDetail ImageEditorApi([FromBody]RequestDetail requestDeail)
        {
            var imageEditor = new Services.EditorClass();
            var editDetail = imageEditor.ManageEdit(requestDeail);
            return editDetail;
        }
    }
}
