
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace adminpanel.Models
{

using System;
    using System.Collections.Generic;
    
public partial class SkillGroup
{

    public SkillGroup()
    {

        this.Skills = new HashSet<Skill>();

    }


    public int Id { get; set; }

    public string SkillGroupName { get; set; }



    public virtual ICollection<Skill> Skills { get; set; }

}

}