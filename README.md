# tgd-unity2022-tuto2

Dans ce deuxième tuto, nous allons voir certains ajouts sur le premier tuto, dont le **déplacement de l'ennemi**, les **triggers** ainsi que les **instanciations d'objets**. Ce code a été fait lors de la séance du 13 octobre 2022.

## Modifications du tuto 1

Dans le tuto 1 s'était glissé un petit problème concernant la caméra, c'est à dire que lorsque le joueur meurt à cause de la collision avec l'ennemi, le jeu s'arrêtait car la **caméra échouait à accéder à la position du joueur** détruit.
Ainsi, la simple correction aura été d'inverser les rôles, et de faire **gérer la caméra par le joueur**. Ce petit problème n'est pas embêtant suivant nos tutos, mais il est intéressant d'intervertir les rôles pour bien comprendre comment bien remplacer les instances d'objets (en copiant collant le code de la caméra, il faut changer les objets afin d'avoir le bon calcul du point de vue de l'objet joueur).

## Mouvement ennemi

Concernant l'ennemi immobile, on va lui **ajouter un déplacement**. Dans le code *Ennemy.cs*, j'ai ajouté une variable d'objet "player" qui contient un GameObject. Cette variable servira à stocker dans l'éditeur notre objet joueur afin de pouvoir accéder à ses paramètres tels que la position, dans le code de notre ennemi. 

Ainsi, on peut commencer dans le update à ajouter un **simple déplacement avant arrière** à notre objet, en créant deux variables *float temps* et *int direction*. En augmentant notre compteur temps à chaque frame avec *Time.deltaTime* (renvoie la valeur de temps entre deux frames) on peut vérifier lorsque *temps>1* afin de réinitialiser notre temps à 0, ainsi qu'en changeant la direction (*direction \*-1*). Enfin, on déplace l'objet en ajoutant à sa position un nouveau *Vector3* et en utilisant direction dedans afin de pouvoir faire varier sa direction.

Cependant, on peut faire des choses bien plus amusantes niveau déplacement de l'ennemi. J'avais dit plus haut qu'on lui ajoutait une variable *GameObject player*, et on va faire **diriger l'ennemi vers le joueur**. Pour se faire, on va d'abord **vérifier l'existence du joueur** au cas où il soit détruit, pour ne pas avoir le même problème qu'avec notre ancienne caméra. en faisant *if (player)*, la condition vérifie si la variable player a bien été instanciée et n'est pas vide. Ainsi on peut ensuite forcer l'objet à se tourner vers le joueur, et si la distance entre les deux est supèrieure à une distance minimale fixée, alors on fait avancer *transform.forward* l'objet afin qu'il se dirige dans la direction qu'il regarde.

