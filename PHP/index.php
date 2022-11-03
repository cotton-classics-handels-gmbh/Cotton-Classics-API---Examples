<?php

require 'vendor/autoload.php';

use GuzzleHttp\Exception\RequestException;
use GuzzleHttp\Client;

// Helper function to die and dump the result.
function dd($variable) {
    echo '<pre>';
    die(var_dump($variable));
}


class APIClient
{
    public Client $client;
    public string $endpoint;

    function __construct(string $endpoint, array $options) {

        $this->client = new Client($options);

        $this->endpoint = $endpoint;
    }

    public function show($query)
    {

        try{

           return json_decode($this->client->get($this->endpoint, ['query' => $query])->getBody());

        }
        catch (RequestException $requestException) {

           return $requestException->getMessage();

        }

    }

    public function create(array $payload)
    {

       try{

          return json_decode($this->client->post($this->endpoint, ['body' => json_encode($payload)])->getBody());

       }
       catch (RequestException $requestException) {

           return $requestException->getMessage();

       }

    }
}

// First we instantiate the API client class with the necessary authorization 'auth'.
$client = new APIClient('https://api.cottonclassics.com/api/Order', [
    'headers' => [
                'Accept' => 'application/json',
                'Content-Type' => 'application/json',
            ],
    'auth' => ['<your_username>', '<your_secret_password>'],
    // Describes the SSL certificate verification behavior of a request. Set to false to disable certificate verification is insecure!.
    'verify' => false
]);

//---------------------------------------------------

/**
 * GET ORDER
 * Get order result for specific Mandator and ProcessID. Just uncomment the lines below.
 * /

//$getOrder = $client->show(['Mandator' => <your_mandator>,'ProcessID' => <your_processID>]));
// dd($getOrder);

//--------------------------------------------------

/**
 * SET ORDER
 * Set order with minimal post data approach. If the order was placed correctly, you will receive a response to your order. Just uncomment the lines below to.
 * /

//$setOrder = $client->create([
//                'Mandator' => <your_mandator>,
//                'CustomerID' => '<your_username>',
//                'DeliveryAddressLine1' => '<your_address>',
//                'DeliveryStreet' => '<your_street>',
//                'DeliveryPostcode' => '<your_postcode>',
//                'DeliveryCity' => '<your_city>',
//                'DeliveryCountry' => '<your_country>',
//                'Positions' => [
//                    '1' => [
//                        'Position' => 'ZUL1',
//                        'SKU' => '10040M24800', //Russell | 040M  -  classic red
//                        'Quantity' => 3
//                    ],
//                    '2' => [
//                        'Position' => '1LLL',
//                        'SKU' => '19030423599', //Kimood | KI0304  -  orange
//                        'Quantity' => 7
//                    ]
//                ]
//        ]));
//dd($setOrder);


//--------------------------------------------------


