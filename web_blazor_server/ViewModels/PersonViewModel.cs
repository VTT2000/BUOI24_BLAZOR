using System;

namespace web_blazor_server.ViewModels;

class PersonViewModel {
    public int Id { get; set;} = 1;
    public string Name { get; set;} = "Nguyễn Văn A";
    public int Age { get; set;} = 18;
    public string image{ get; set;} = "";
    public PersonViewModel() {
        image = $"https://i.pravatar.cc?u={Id}";
    }
    public PersonViewModel(int newId, string newName, int newAge) {
        Id = newId;
        Name = newName;
        Age= newAge;
        image = $"https://i.pravatar.cc?u={Id}";
    }
}