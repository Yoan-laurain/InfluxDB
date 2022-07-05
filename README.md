Projet d'intégration et de présentation d' InfluxDB
===================================================

# Tuto d'installation Docker 
## Prérequies :
      * Docker ou Docker Desktop d'installer sur la machine 
      * WSL2 installer 
      
# Installation :
      * ``` docker pull influxdb:2.0.7 ```
      * ``` docker run --name influxdb -p 8086:8086 influxdb:2.0.7 ```
      
# Tuto d'installation sur Linux/Debian 11/Ubuntu20 (pour utilisation serveur)
## Prérequies :
      * Serveur Debian11 ou Ubuntu20 ( à jour )
## Installation :
      * Ajout dépôts (APT): 
                       1. ``` wget -q https://repos.influxdata.com/influxdb.key ``` 
                       2. ``` echo '23a1c8836f0afc5ed24e0486339d7cc8f6790b83886c4c96995b88a061c5bb5d influxdb.key' | sha256sum -c && cat influxdb.key | gpg --dearmor | sudo tee /etc/apt/trusted.gpg.d/influxdb.gpg > /dev/null ```
                       3. ``` echo 'deb [signed-by=/etc/apt/trusted.gpg.d/influxdb.gpg] https://repos.influxdata.com/debian stable main' | sudo tee /etc/apt/sources.list.d/influxdata.list ```
                       4. ``` sudo apt-get update && sudo apt-get install influxdb2 ```
                       
      * Ou depuis le package (DPKG): 
                       1. ``` wget https://dl.influxdata.com/influxdb/releases/influxdb2-2.2.0-xxx.deb ```
                       2. ``` sudo dpkg -i influxdb2-2.2.0-xxx.deb ```
                       
      * Activation des services : 
                       1. ``` sudo systemctl start influxdb ```
                       2. ``` sudo systemctl enable influxdb ```
                       //-- On vérifie que le service tourne --// 
                       3. ``` sudo systemctl status influxdb ```
