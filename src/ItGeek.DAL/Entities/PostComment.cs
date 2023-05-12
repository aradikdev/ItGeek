namespace ItGeek.DAL.Entities;

public class PostComment
{
	public int PostId { get; set; }
	public int CommentId { get; set; }
	public Post Post { get; set; } = null!;
	public Comment Comment { get; set; } = null!;
}
