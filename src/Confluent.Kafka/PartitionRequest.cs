using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confluent.Kafka
{
    public class PartitionRequest<TKey, TValue>
    {
        public PartitionRequest(Message<TKey, TValue> message, byte[] keyBytes, byte[] valueBytes)
        {
            this.Message = message;
            this.KeyBytes = keyBytes;
            this.ValueBytes = valueBytes;
        }

        public Message<TKey, TValue> Message { get; }
        public byte[] KeyBytes { get; }
        public byte[] ValueBytes { get; }
    }
}
