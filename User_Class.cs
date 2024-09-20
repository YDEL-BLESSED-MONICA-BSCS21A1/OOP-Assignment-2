using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class User
{
    private List<Identity> _users;

    public void LoadUsersFromJson(string filePath)
    {
        // Read the JSON file and deserialize into a list of Identity objects
        string jsonData = File.ReadAllText(filePath);
        _users = JsonConvert.DeserializeObject<List<Identity>>(jsonData);
    }

    public bool IsValid(string username, string password)
    {
        // Check if any user matches the given username and password
        foreach (var user in _users)
        {
            if (user.Username == username && user.Password == password)
            {
                return true;
            }
        }
        return false;
    }
}
