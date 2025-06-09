using System.Text.Json.Serialization;

namespace DataEntities;

public sealed class UserRegistration {
    /*
    @FormParam("username")
    @NotBlank(message = "Username is required")
    @Size(min = 4, max = 20, message = "Username must be 4 to 20 characters")
    public String username;

    @FormParam("email")
    @NotBlank(message = "Email is required")
    @Email(message = "Must be a valid email")
    private String email;

    @FormParam("phone")
    @Pattern(
        regexp = "^\\(\\d{3}\\) \\d{3}-\\d{4}$", 
        message = "Phone must match (123) 456-7890 format"
    )
    private String phone;
    
    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getPhone() {
        return phone;
    }

    public void setPhone(String phone) {
        this.phone = phone;
    }
/* 
    @Pattern(regexp = "^[A-Z0-9]{8}$", message = "Product code must be 8 uppercase letters or digits")
private String productCode; */

//String canonicalPhone = phone.trim().replaceAll("[^\\d]", "");
// Validate canonicalPhone instead of raw input

}