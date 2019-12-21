# tfs_alert_bot

how to run

docker build -t alert .

docker run -p 80:80 -d -e TOKEN=<Token> -e HOST=<host> alert
