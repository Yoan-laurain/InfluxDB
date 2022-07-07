Projet d'intégration et de présentation d' InfluxDB
===================================================

# Tuto d'installation Docker 
## Prérequis :

- Docker ou Docker Desktop d'installer sur la machine : https://www.docker.com/products/docker-desktop/

- WSL2 installer : 
  - Installation : https://docs.microsoft.com/fr-fr/windows/wsl/install )
  - Mise à jour : https://wslstorestorage.blob.core.windows.net/wslblob/wsl_update_x64.msi )

- <!> Si jamais vous avez cette fenêtre d'erreur : 
  ![alt-text](https://github.com/Yoan-laurain/InfluxDB/blob/main/Images/WSL2Impossible.png)
- Tapez : `wsl --set-default-version 2` dans PowerShell 
      
## Installation :

1. `docker pull influxdb:2.0.7`

2. `docker run --name influxdb -p 8086:8086 influxdb:2.0.7` 

## Setup :

#### Depuis l'interface WEB : `http://localhost:8086` 


# Tuto d'installation sur Linux/Debian 11/Ubuntu20 (pour utilisation serveur)

## Prérequis :

- Serveur Debian11 ou Ubuntu20 ( à jour )

## Installation :

Ajout dépôts (APT): 
1. `wget -q https://repos.influxdata.com/influxdb.key` 
2. `echo '23a1c8836f0afc5ed24e0486339d7cc8f6790b83886c4c96995b88a061c5bb5d influxdb.key' | sha256sum -c && cat influxdb.key | gpg --dearmor | sudo tee /etc/apt/trusted.gpg.d/influxdb.gpg > /dev/null`
3. `echo 'deb [signed-by=/etc/apt/trusted.gpg.d/influxdb.gpg] https://repos.influxdata.com/debian stable main' | sudo tee /etc/apt/sources.list.d/influxdata.list`
4. `sudo apt-get update && sudo apt-get install influxdb2`                  
<br/> Ou depuis le package (DPKG): 
1. `wget https://dl.influxdata.com/influxdb/releases/influxdb2-2.2.0-xxx.deb`
2. `sudo dpkg -i influxdb2-2.2.0-xxx.deb`
                       
Activation des services : 
1. `sudo systemctl start influxdb`
2. `sudo systemctl enable influxdb`
<br/> On vérifie que le service tourne
3. `sudo systemctl status influxdb`

## Setup :

#### En ligne de commande :
1. `influx setup`
2. Rentrez les informations dans l'ordre : ( Username, Password, PassAgain, Organisation, Bucket( base de donnée),  type of time '0' ) 
3. `influx auth list`
- Enregistrer le token sera utile plus tard 

#### Depuis l'interface Web : `http://<ipdevotreserveur>:8086` 

## Initialisation depuis l'interface Web 

![alt-text](https://github.com/Yoan-laurain/InfluxDB/blob/main/Images/start_web.png)
![alt-text](https://github.com/Yoan-laurain/InfluxDB/blob/main/Images/user__init_web.png)

Rentrer l'intégralité des champs

![alt-text](https://github.com/Yoan-laurain/InfluxDB/blob/main/Images/skip_web.png)
![alt-text](https://github.com/Yoan-laurain/InfluxDB/blob/main/Images/interface_web.png)


