# ProjLogsRabbitMQ

TUTORIAL INSTALAÇÃO RABBITMQ:

https://www.rabbitmq.com/tutorials/tutorial-one-dotnet.html

INSTALAÇÃO RABBITMQ:

1-Instalar dependência:
- https://github.com/erlang/otp/releases/download/OTP-24.3.3/otp_win64_24.3.3.exe

2-Instalar RabbitMQ:
- https://github.com/rabbitmq/rabbitmq-server/releases/download/v3.9.14/rabbitmq-server-3.9.14.exe

3-Abri Terminal:
- C:\Users\André>cd C:\Program Files\RabbitMQ Server\rabbitmq_server-3.9.14\sbin

4-Habilitar Plugin
- C:\Program Files\RabbitMQ Server\rabbitmq_server-3.9.14\sbin>rabbitmq-plugins enable rabbitmq_management
Enabling plugins on node rabbit@DESKTOP-V1AUI59:
rabbitmq_management
The following plugins have been configured:
  rabbitmq_management
  rabbitmq_management_agent
  rabbitmq_web_dispatch
Applying plugin configuration to rabbit@DESKTOP-V1AUI59...
Plugin configuration unchanged.

5-Abrir Aplicação Rabbit:
- http://localhost:15672/

6-Usuário e Senha:
- usuario: guest
- senha: guest


7-Para executar a "Migration" e o "Update" quanto temos múltiplos projetos dentro de uma solução:
 - Add-Migration InitialCreate -s ProjLogsRabbitMQ.ApiToSQLServer -p ProjLogsRabbitMQ.ApiToSQLServer 
 - update-database -s ProjLogsRabbitMQ.ApiToSQLServer -p ProjLogsRabbitMQ.ApiToSQLServer 


