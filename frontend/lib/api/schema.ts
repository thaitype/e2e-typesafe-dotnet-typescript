/**
 * This file was auto-generated by openapi-typescript.
 * Do not make direct changes to the file.
 */

export interface paths {
    "/bff/BffWeatherForecast": {
        parameters: {
            query?: never;
            header?: never;
            path?: never;
            cookie?: never;
        };
        get: operations["BffGetWeatherForecast"];
        put?: never;
        post?: never;
        delete?: never;
        options?: never;
        head?: never;
        patch?: never;
        trace?: never;
    };
    "/api/WeatherForecast": {
        parameters: {
            query?: never;
            header?: never;
            path?: never;
            cookie?: never;
        };
        get: operations["GetWeatherForecast"];
        put?: never;
        post?: never;
        delete?: never;
        options?: never;
        head?: never;
        patch?: never;
        trace?: never;
    };
}
export type webhooks = Record<string, never>;
export interface components {
    schemas: {
        DateOnly: {
            /** Format: int32 */
            year?: number;
            /** Format: int32 */
            month?: number;
            /** Format: int32 */
            day?: number;
            dayOfWeek?: components["schemas"]["DayOfWeek"];
            /** Format: int32 */
            readonly dayOfYear?: number;
            /** Format: int32 */
            readonly dayNumber?: number;
        };
        /**
         * Format: int32
         * @enum {integer}
         */
        DayOfWeek: 0 | 1 | 2 | 3 | 4 | 5 | 6;
        WeatherForecast: {
            date?: components["schemas"]["DateOnly"];
            /** Format: int32 */
            temperatureC?: number;
            /** Format: int32 */
            readonly temperatureF?: number;
            summary?: string | null;
        };
    };
    responses: never;
    parameters: never;
    requestBodies: never;
    headers: never;
    pathItems: never;
}
export type $defs = Record<string, never>;
export interface operations {
    BffGetWeatherForecast: {
        parameters: {
            query?: never;
            header?: never;
            path?: never;
            cookie?: never;
        };
        requestBody?: never;
        responses: {
            /** @description Success */
            200: {
                headers: {
                    [name: string]: unknown;
                };
                content: {
                    "text/plain": components["schemas"]["WeatherForecast"][];
                    "application/json": components["schemas"]["WeatherForecast"][];
                    "text/json": components["schemas"]["WeatherForecast"][];
                };
            };
        };
    };
    GetWeatherForecast: {
        parameters: {
            query?: never;
            header?: never;
            path?: never;
            cookie?: never;
        };
        requestBody?: never;
        responses: {
            /** @description Success */
            200: {
                headers: {
                    [name: string]: unknown;
                };
                content: {
                    "text/plain": components["schemas"]["WeatherForecast"][];
                    "application/json": components["schemas"]["WeatherForecast"][];
                    "text/json": components["schemas"]["WeatherForecast"][];
                };
            };
        };
    };
}
