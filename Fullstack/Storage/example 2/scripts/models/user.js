export default class User {

    constructor(name, email, dob, pass) {
        this.Name = name;
        this.Email = email;
        this.DateOfBirth = dob;
        this.Password = pass;
    }

    set Name(value) { this.name = value; }
    get Name() { return this.name; }

    set Email(value) { this.email = value; }
    get Email() { return this.email; }

    set DateOfBirth(value) { this.dob = value; }
    get DateOfBirth() { return this.dob; }

    set Password(value) { this.pass = value; }
    get Password() { return this.pass; }
}