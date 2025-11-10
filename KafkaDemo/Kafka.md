# KafKa
Apache Kafka is a distributed event streaming platform used to build real-time data pipelines and applications.
- Kafka is like a post office for data. It receives messages (data), stores them, and delivers them to recipients.
- Originally developed by LinkedIn, it’s now an open-source project under the Apache Software Foundation.
- It’s designed for high-throughput, fault-tolerant, scalable data streaming.

## How Kafka Works (Simplified)
- Producer sends data → to a topic.
- Kafka stores the data in partitions across brokers.
- Consumers subscribe to topics and read data in real-time or later.
- Kafka ensures durability (data is stored safely) and fault tolerance (system keeps working even if parts fail).

## Steps to create an app 
dotnet new console -n KafkaDemo
cd KafkaDemo
dotnet add package Confluent.Kafka

## Starting Kafka locally via Docker
- Create a yml file using below content
```
	services:
	  zookeeper:
		image: confluentinc/cp-zookeeper:latest
		environment:
		  ZOOKEEPER_CLIENT_PORT: 2181
		  ZOOKEEPER_TICK_TIME: 2000

	  kafka:
		image: confluentinc/cp-kafka:7.3.0
		depends_on:
		  - zookeeper
		ports:
		  - "9092:9092"
		environment:
		  KAFKA_BROKER_ID: 1
		  KAFKA_ZOOKEEPER_CONNECT: zookeeper:2181
		  KAFKA_LISTENERS: PLAINTEXT://0.0.0.0:9092
		  KAFKA_ADVERTISED_LISTENERS: PLAINTEXT://host.docker.internal:9092
		  KAFKA_OFFSETS_TOPIC_REPLICATION_FACTOR: 1
```

- Start the Kafka Service: docker compose up -d

## Run the Application
- Run the Bash commands in two different instances to run the producer and consumer separately 
```
	dotnet run produce
	dotnet run 
```
- Check if Kafka is Listening
```
	telnet localhost 9092
```