import pika

params = pika.URLParameters("amqp://jnzwnaml:awUJK6qH5-UVAf97RgUz18b-K9zAgW5q@mosquito.rmq.cloudamqp.com/jnzwnaml")
connection = pika.BlockingConnection(params)
channel = connection.channel()

channel.queue_declare(queue='hello')

channel.basic_publish(exchange='', routing_key='hello', body='Hello World!')
print(" [x] Sent 'Hello World!'")
connection.close()