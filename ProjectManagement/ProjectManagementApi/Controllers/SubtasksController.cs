using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Core.UseCases.Subtasks.Commands.DeleteSubtask;

namespace ProjectManagementApi.Controllers
{
    public class SubtasksController : ApiControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> AddSubtaskToTask()
        {
            throw new NotImplementedException();
        }

        [HttpPatch]
        public async Task<ActionResult> UpdateSubtaskContent()
        {
            throw new NotImplementedException();
        }

        [HttpPatch]
        public async Task<ActionResult> UpdateSubtaskStatus()
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSubtask(int id)
        {
            await Mediator.Send(new DeleteSubtaskCommand()
            {
                Id = id
            });
            return NoContent();
        }
    }
}