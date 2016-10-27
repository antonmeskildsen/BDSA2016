using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BDSA2016.Lecture07.Lib.Bridge
{
    public interface ICharacterRepository : IDisposable
    {
        Task<int> CreateAsync(Character character);

        Task<Character> FindAsync(int id);

        Task<IEnumerable<Character>> ReadAsync();

        Task<bool> UpdateAsync(Character character);

        Task<bool> DeleteAsync(int id);
    }
}