namespace FriendLetter.Objects
{
  public class LetterVariables
  {
    private string _recipient;
    private string _sender;
    private string _date;
    private string _place;
    private string _souvenir;

    public string GetRecipient()
    {
      return _recipient;
    }

    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }

    public string GetSender()
    {
      return _sender;
    }

    public void SetSender(string newSender)
    {
      _sender = newSender;
    }

    public string GetDate()
    {
      return _date;
    }

    public void SetDate(string newDate)
    {
      _date = newDate;
    }

    public string GetPlace()
    {
      return _place;
    }

    public void SetPlace(string newPlace)
    {
      _place = newPlace;
    }

    public string GetSouvenir()
    {
      return _souvenir;
    }

    public void SetSouvenir(string newSouvenir)
    {
      _souvenir = newSouvenir;
    }
  }
}
