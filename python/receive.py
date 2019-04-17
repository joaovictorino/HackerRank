import pika

params = pika.URLParameters("amqp://jnzwnaml:awUJK6qH5-UVAf97RgUz18b-K9zAgW5q@mosquito.rmq.cloudamqp.com/jnzwnaml")
connection = pika.BlockingConnection(params)
channel = connection.channel()

channel.queue_declare(queue='hello')


def callback(ch, method, properties, body):
    print(" [x] Received %r" % body)


channel.basic_consume(
    queue='hello', on_message_callback=callback, auto_ack=True)

print(' [*] Waiting for messages. To exit press CTRL+C')
channel.start_consuming()