const database = 'crud';
const collection = 'create';

// Create a new database.
use(database);

// Create a new collection.
//db.createCollection(collection);




db.create.insertOne(
    {
        nome:"Anderson",
        idade:48,
        trabalhando:true,
        hobbies:["Jogar","Programar"]
    }
)


use ('crud')
db.create.find({},{nome:1})



use ('crud')

db.provas.insertMany([
    {
        nome:"João",
        notas:[10,9,8]
    },
    {
        nome:"Silvio",
        notas:[7,6,5]
    }

]
    
)


use ('crud')
db.provas.find({},{nome:1,notas:1})


-----------------------------

use('loja');

db.mercado.insertMany([
    {
        nome:"arroz 5k",
        preço:25.5,
        disponibilidade:50,
    },
    {
        nome:"ovo  30 unit.",
        preço:15,
        disponibilidade:150,
    },
    {
        nome:"Feijão 1k",
        preço:15.55,
        disponibilidade:250,
    }

]   
)

use('loja')
db.mercado.find({},{nome:1,preço:1,disponibilidade:1})

----------------------------------------------------------------

use('dadosDeCarros');

db.carros.insertMany([
    {
        _id:"01",
        marca:"Fiat",
        modelo:"Palio",
        ano:2018,
        quilometragem:100000,
    },
    {
        _id:"02",
        marca:"Ford",
        modelo:"gol",
        ano:2019,
        quilometragem:200000,
    },
    {
        _id:"03",
        marca:"volkswagen",
        modelo:"silica",
        ano:2012,
        quilometragem:40000,
    },
    {
        _id:"04",
        marca:"ferrari",
        modelo:"x1",
        ano:2023,
        quilometragem:0,
    },

]   
)

use('dadosDeCarros')
db.carros.find({},{_id:1,marca:1,modelo:1,ano:1,quilometragem:1}).pretty()


------------------------------------------------------------------------------------------------

use('Biblioteca');
db.livros.find({title:"MongoDB in Action"},{_id:1,title:1,authors:1}).pretty()
db.livros.find({authors:'Jason R. Weiss'},{_id:1,title:1,authors:1}).pretty()

------------------------------------------------------------------------------------------------

use('Biblioteca');

db.livros.updateOne({_id:20},{$set:{title:"meu primeiro update"}})

db.livros.find({_id:20},{_id:1,title:1,authors:1}).pretty()

------------------------------------------------------------------------------------------------

use('Biblioteca');

db.livros.updateMany({
    pageCount:{
        $gt:500
    }
},
{$set:{bestseller:true}})


use('Biblioteca');
db.livros.find({bestseller:true},{title:1,pageCount:1}).pretty()

------------------------------------------------------------------------------------------------

use('Biblioteca');

db.livros.deleteOne({isbn:"1933988320"})


use('Biblioteca');
db.livros.deleteMany({categories:"PowerBuilder"})


use('Biblioteca');
db.livros.find(
    {
        $or:[
            {categories:"PowerBuilder"},
        
            {isbn:"1933988320"}
        ]   
        
    },
    {nome:1}
).pretty()

-------------------------------------------------------------------------------------------------

use ('restaurante')
db.lanchoneteBra.find({
    $and: [{
        rating:{
            $gte:3
        }
    },{
        type_of_food:"Breakfast",
    }]
},{name:1,type_of_food:1,rating:1}).pretty()





use('restaurante')
db.lanchoneteBra.find({rating:2},{name:1})

use('restaurante')
db.lanchoneteBra.updateMany(
    {
        rating:{$lte:2}
    },
    {
        $set:{restaurante_ruim:true}
    })





use('restaurante')
db.lanchoneteBra.find({restaurante_ruim:{ $exists: true }},{name:1,rating:1}).pretty()


