# Kafka
Post office for data - Receives, Stores and Delivers the messages.
Apache Kafka is a distributed event streaming platform used to build real-time data pipelines and applications.

## How Kafka Works (Simplified)
- Producer sends data → to a topic.
- Kafka stores the data in partitions across brokers.
- Consumers subscribe to topics and read data in real-time or later.
- Kafka ensures durability (data is stored safely) and fault tolerance (system keeps working even if parts fail).

## Key Components
| Component         | Role in Kafka                                                                         |
|-------------------|---------------------------------------------------------------------------------------|
| **Producer**      | Sends (publishes) data to Kafka topics.                                               |
| **Consumer**      | Reads (subscribes to) data from Kafka topics.                                         |
| **Topic**         | A category or feed name to which records are sent by producers.                       |
| **Broker**        | A Kafka server that stores data and serves clients. Multiple brokers form a cluster.  |
| **Partition**     | Topics are split into partitions for parallel processing and scalability.             |
| **Zookeeper**     | Manages and coordinates Kafka brokers (being replaced by KRaft in newer versions).    |
| **Kafka Cluster** | A group of Kafka brokers working together to handle data streams.                     |
