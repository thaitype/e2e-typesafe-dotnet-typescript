import client from "../lib/api";

async function getWeather() {
  return await client.GET("/bff/BffWeatherForecast");
}

export default async function Home() {
  const fact = await getWeather();

  return (
    <div>
      <code>{JSON.stringify(fact.data, undefined, 2)}</code>
    </div>
  );
}
