using System.Collections.Generic;

namespace MD4_SQL.Data
{
    public class CourseDetailsViewModel
    {
        public Course? Course { get; set; }
        public List<Assignment>? Assignments { get; set; }
    }
}
/*
 In ASP.NET Core MVC, a ViewModel is a design pattern used to pass
data from the controller to the view. It is not strictly an MVVM (Model-View-ViewModel) 
pattern as used in frameworks like WPF or Xamarin, but it serves a similar purpose in 
separating concerns and organizing data.

What is a ViewModel?
A ViewModel is a class that contains the data and logic needed for a specific view. 
It can combine multiple models or include additional properties that 
are not part of the database models. The ViewModel is tailored to the needs of the view,
making it easier to render the view and handle user interactions.
Why Use a ViewModel?
    1.	Separation of Concerns: It separates the data logic from the presentation logic,
        making the code more maintainable and testable.
    2.	Combining Multiple Models: It allows you to combine data from multiple 
        models into a single object that can be passed to the view.
    3.	Additional Properties: It can include additional properties that are 
        not part of the database models but are needed for the view
        (e.g., calculated fields, user input).
 */
