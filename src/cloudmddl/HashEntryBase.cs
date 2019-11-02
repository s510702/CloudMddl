using System;

namespace cloudmddl
{
    /// <summary>
    /// ANything that can be stored in the hash table should inherit from this base
    /// </summary>
    public class HashEntryBase
    {
        /// <summary>
        /// Id for and entry
        /// </summary>
        public Guid Id { get; }

        public virtual UInt64 GetSignature() { throw new NotImplementedException(); }

        public HashEntryBase()
        {
            Id = Guid.NewGuid();
        }
    }
}
