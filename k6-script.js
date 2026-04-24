import http from 'k6/http';
import { sleep } from 'k6';

export default function () {
  http.get('http://34.51.71.130'); // Tu IP pública
  sleep(1);
}