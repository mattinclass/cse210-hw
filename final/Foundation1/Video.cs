
class Video
{
    private string _author;
    private string _title;
    private int _length;
    public List<Comment> commentList = new List<Comment>();



    public void SetAuthor(string author)
    {
        _author = author;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetTitle()
    {
        return _title;
    }
    public void SetLength(int length)
    {
        _length = length;
    }
    public int GetLength()
    {
        return _length;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds \nComments: {commentList.Count()}");
    }
    public void CreateComment(string name, string text)
    {
        Comment myComment = new Comment();
        myComment.SetName(name);
        myComment.SetText(text);
        commentList.Add(myComment);
    }
    
}