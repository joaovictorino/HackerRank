from celery import Celery

app = Celery('tasks')
app.conf.update({
    'result_backend': 'file:///rberesult',
    'broker_url': 'filesystem://',
    'broker_transport_options': {
        'data_folder_in': './out',
        'data_folder_out': './out',
        'data_folder_processed': './processed'
    }})

@app.task
def add(x, y):
    fd = open("/tmp/out.txt", "a")
    fd.write("oi, juao\n")
    fd.close()
    return x+y+1