using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confluent.Kafka
{
    public interface IPartitioner : IDisposable
    {
        /**
         * Compute the partition for the given record.
         *
         * @param topic The topic name
         * @param key The key to partition on (or null if no key)
         * @param keyBytes The serialized key to partition on( or null if no key)
         * @param value The value to partition on or null
         * @param valueBytes The serialized value to partition on or null
         * @param cluster The current cluster metadata
         */
//        int Partition(string topic, object key, byte[] keyBytes, object value, byte[] valueBytes, Cluster cluster);

        /**
         * This is called when partitioner is closed.
         */
        void Close();

        /**
         * Notifies the partitioner a new batch is about to be created. When using the sticky partitioner,
         * this method can change the chosen sticky partition for the new batch. 
         * @param topic The topic name
         * @param cluster The current cluster metadata
         * @param prevPartition The partition previously selected for the record that triggered a new batch
         */
        //void OnNewBatch(string topic, Cluster cluster, int prevPartition);
    }
}
