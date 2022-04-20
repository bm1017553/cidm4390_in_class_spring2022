using System;
namespace domain.SpeakerAggregate;

//this is an example of "I" in SOLID
public interface ISpeakerHelper
{
    public string ValidateFirstName(string fname);
    public string ValidateLastName(string lname);

    //ID Framework w/ sendgrid?
    public string ValidateEmailAddrress(string email);
}

public class MySpeakerHelper : ISpeakerHelper
{
    public string GetFirstName(string fname)
    {
        // TODO: validation steps
        if(fname.Length == 0){
            throw new ArgumentException();
        }
        return fname;
    }
    public string GetLastName(string lname)
    {
        return string.Empty;
    }
    public string GetEmailAddrress(string email)
    {
        return string.Empty;
    }

    public Speaker CreateSpeaker(string fname, string lname, string email)
    {
        Speaker speaker = new Speaker()
        {
            FirstName = ValidateFirstName(fname),
            LastName = ValidateLastName(lname)
        };
    }
}