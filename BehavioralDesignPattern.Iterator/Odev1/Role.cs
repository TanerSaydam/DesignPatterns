using System.Collections;

namespace BehavioralDesignPattern.Iterator.Odev1;

public class Role
{
    public string Name { get; set; }
}

public class RoleCollection : IEnumerable<Role>
{
    IList<Role> roles = new List<Role>();
    public void RoleEkle(Role role)
    {
        roles.Add(role);
    }
    public IEnumerator<Role> GetEnumerator()
    {
        return roles.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
