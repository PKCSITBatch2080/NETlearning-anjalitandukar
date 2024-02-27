// //Single Inheritance

// class CSStudent : Student  , IGradeable // parent:child,, inheritted property // multiple inheritance
// {

// public CSStudent(string name , byte rn, string pTitle) 
//      : base (name,rn)  //parent class ko constructor call garna 
// {
//     ProjectTitle = pTitle;
// }
//     public string ProjectTitle {get; set;}

//     public string InernWork { get; set; }

//     public double GetGrade ()=> 3.6;

// }

// Single Inheritance
using System;

class CSStudent : Student, IGradeable   // Multiple Inheritance
{
    public CSStudent(string name, byte rn, string pTitle) 
        : base(name, rn)
    {
        ProjectTitle = pTitle;
    }

    public string ProjectTitle { get; set; }
    public string InternWork { get; set; }

    public double GetGrade() => 3.6;
}