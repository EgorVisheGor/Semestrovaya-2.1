
create table "user"(
     id uuid primary key,
     password text not null,
     login varchar(240) unique not null,
     name varchar(240) not null,
     surname varchar(240), 
     patronymic varchar(240),
     date_of_birth date not null,
     image_path varchar(1024)
);

create table recipe(
    id serial primary key,
    rating numeric(3,2) default 0.00, 
    posted_at date not null,
    description text not null,
    author_id uuid references "user" (id)
);

create table recipe_image(
    id serial primary key,
    recipe_id int references recipe (id),
    path varchar(1024)                
);

create table comment(
    id serial primary key,
    recipe_id int references recipe(id),
    author_id uuid references "user"(id),
    rating int check ( rating >= 0 and rating <= 5),
    posted_at date not null,
    description text not null
);

create table compilation(
    id serial primary key,
    name varchar(240) not null,
    author_id uuid references "user"(id)
);

create table compilation_recipe(
    id serial primary key,
    recipe_id int references recipe(id),
    compilation_id int references compilation(id)
);

create table favourite_recipe(
    id serial primary key,
    recipe_id int references recipe(id),
    owner_id uuid references "user"(id)
);