using Nancy;
using FriendLetter.Objects;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/greeting_card"] = _ => {
        LetterVariables myLetterVariables = new LetterVariables();
        myLetterVariables.SetRecipient(Request.Query["recipient"]);
        myLetterVariables.SetSender(Request.Query["sender"]);
        myLetterVariables.SetDate(Request.Query["date"]);
        myLetterVariables.SetPlace(Request.Query["place"]);
        myLetterVariables.SetSouvenir(Request.Query["souvenir"]);
        return View["hello.cshtml", myLetterVariables];
      };
      Get["/form"] = _ => {
        return View["form.cshtml"];
      };
    }
  }
}
