select a.*
from actor a
     inner join film_actor fa on fa.actor_id = a.actor_id

where fa.film_id=1
