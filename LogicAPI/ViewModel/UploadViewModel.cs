using System.ComponentModel.DataAnnotations;

namespace LogicAPI.ViewModel
{
    public class UploadViewModel
    {
        [Required]
        public int RoomId { get; set; }
        [Required]
        public IFormFile File { get; set; }
    }
}
