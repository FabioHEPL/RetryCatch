# Cahier des charges

## Consignes spécifiques
- Une seule mécanique de jeu au début (armes à feu, au nombre de 3 initialement)
- Niveaux fixes (pas en procédural)
- Reset du niveau quand on meurt
- Mécanique de jeu simple au début : les abilités seront une fonctionnalité supplémentaire

## Fonctionnalités
### Déplacement
Faire un déplacement vertical et horizontal dans l'espace 2D
Comment sait-on que la tâche est terminée ?
- le personnage se déplace sur l'axe horizontal et vertical dans l'espace
- possibilité de lui assigner une vitesse de déplacement (dans l'inspector)

### Système de tir
Comment sait-on que la tâche est terminée ?
- le tir part du personnage sur l'axe de vue (où le personnage regarde)
- lifetime du projectile (en secondes, dans l'inspector)


### Items
#### Inventaire
Comment sait-on que la tâche est terminée ?
- un nombre de slots prédéfinis, seulement pour les armes

#### Fonction de pickup
Comment sait-on que la tâche est terminée ?
- lorsqu'on appuie sur une touche, l'item disparait à l'écran
- en même temps, il apparaît dans l'inventaire (et sauvegardé)

#### Fonction de selection
Comment sait-on que la tâche est terminée ?
- à l'aide d'un input, le joueur peut changer d'arme
- **Préconditions** : il faut que l'arme choisie soit dans l'inventaire
- **Postconditions** : //


## Charte graphique
