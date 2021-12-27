run:
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d --build

net:
docker network inspect ocelot-agregation_default

gateway:
curl http://localhost/api/deliveries/delivery/d228e1e1-5f4e-4b85-96ae-8c5dec9889c3
curl http://localhost/api/ordering/order/d228e1e1-5f4e-4b85-96ae-8c5dec9889c3

curl http://localhost/api/order-delivery/d228e1e1-5f4e-4b85-96ae-8c5dec9889c3

deliveries:
curl http://localhost/api/delivery/d228e1e1-5f4e-4b85-96ae-8c5dec9889c3

orders:
curl http://localhost/api/order/d228e1e1-5f4e-4b85-96ae-8c5dec9889c3