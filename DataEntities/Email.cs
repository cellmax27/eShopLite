namespace DataEntities;

public sealed class Email {
    private int id;
    private string? subject;
    private string? from;
    private string? to;
    private string? body;
    private DateTime date;
    private List<Attachment>? attachments;
}